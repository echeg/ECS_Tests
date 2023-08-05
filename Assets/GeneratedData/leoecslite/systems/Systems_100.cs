using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System100 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component408> _p1;
EcsPool<Component371> _p2;
EcsPool<Component161> _p3;
EcsPool<Component450> _p4;
EcsPool<Component192> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component408>().Inc<Component371>().Inc<Component161>().Inc<Component450>().End();
   _p1 = _world.GetPool<Component408>();
   _p2 = _world.GetPool<Component371>();
   _p3 = _world.GetPool<Component161>();
   _p4 = _world.GetPool<Component450>();
   _pl0 = _world.GetPool<Component192>();
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
