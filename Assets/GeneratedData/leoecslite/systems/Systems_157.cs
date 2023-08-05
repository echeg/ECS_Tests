using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System157 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component161> _p1;
EcsPool<Component294> _p2;
EcsPool<Component59> _p3;
EcsPool<Component346> _p4;
EcsPool<Component166> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component161>().Inc<Component294>().Inc<Component59>().Inc<Component346>().End();
   _p1 = _world.GetPool<Component161>();
   _p2 = _world.GetPool<Component294>();
   _p3 = _world.GetPool<Component59>();
   _p4 = _world.GetPool<Component346>();
   _pl0 = _world.GetPool<Component166>();
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
