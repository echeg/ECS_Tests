using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System116 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component370> _p1;
EcsPool<Component204> _p2;
EcsPool<Component241> _p3;
EcsPool<Component26> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component370>().Inc<Component204>().Inc<Component241>().End();
   _p1 = _world.GetPool<Component370>();
   _p2 = _world.GetPool<Component204>();
   _p3 = _world.GetPool<Component241>();
   _pl0 = _world.GetPool<Component26>();
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
