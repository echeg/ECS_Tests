using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System359 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component420> _p1;
EcsPool<Component451> _p2;
EcsPool<Component236> _p3;
EcsPool<Component426> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component420>().Inc<Component451>().Inc<Component236>().End();
   _p1 = _world.GetPool<Component420>();
   _p2 = _world.GetPool<Component451>();
   _p3 = _world.GetPool<Component236>();
   _pl0 = _world.GetPool<Component426>();
 }
 public void Run (IEcsSystems systems) {
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
