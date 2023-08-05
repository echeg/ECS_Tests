using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System176 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component192> _p1;
EcsPool<Component133> _p2;
EcsPool<Component248> _p3;
EcsPool<Component235> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component192>().Inc<Component133>().Inc<Component248>().End();
   _p1 = _world.GetPool<Component192>();
   _p2 = _world.GetPool<Component133>();
   _p3 = _world.GetPool<Component248>();
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
