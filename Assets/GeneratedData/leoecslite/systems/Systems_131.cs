using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System131 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component382> _p1;
EcsPool<Component12> _p2;
EcsPool<Component407> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component382>().Inc<Component12>().End();
   _p1 = _world.GetPool<Component382>();
   _p2 = _world.GetPool<Component12>();
   _pl0 = _world.GetPool<Component407>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
