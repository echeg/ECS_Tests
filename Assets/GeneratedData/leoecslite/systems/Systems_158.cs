using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System158 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component208> _p1;
EcsPool<Component480> _p2;
EcsPool<Component153> _p3;
EcsPool<Component255> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component208>().Inc<Component480>().Inc<Component153>().End();
   _p1 = _world.GetPool<Component208>();
   _p2 = _world.GetPool<Component480>();
   _p3 = _world.GetPool<Component153>();
   _pl0 = _world.GetPool<Component255>();
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
