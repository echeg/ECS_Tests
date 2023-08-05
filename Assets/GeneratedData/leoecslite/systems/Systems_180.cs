using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System180 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component267> _p1;
EcsPool<Component118> _p2;
EcsPool<Component451> _p3;
EcsPool<Component58> _p4;
EcsPool<Component235> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component267>().Inc<Component118>().Inc<Component451>().Inc<Component58>().End();
   _p1 = _world.GetPool<Component267>();
   _p2 = _world.GetPool<Component118>();
   _p3 = _world.GetPool<Component451>();
   _p4 = _world.GetPool<Component58>();
   _pl0 = _world.GetPool<Component235>();
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
