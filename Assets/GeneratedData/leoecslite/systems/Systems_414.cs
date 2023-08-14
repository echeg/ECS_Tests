using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System414 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component152> _p1;
EcsPool<Component47> _p2;
EcsPool<Component276> _p3;
EcsPool<Component100> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component152>().Inc<Component47>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component152>();
   _p2 = _world.GetPool<Component47>();
   _p3 = _world.GetPool<Component276>();
   _pl0 = _world.GetPool<Component100>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
