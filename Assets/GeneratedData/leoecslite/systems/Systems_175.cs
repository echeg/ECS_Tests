using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System175 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component436> _p1;
EcsPool<Component150> _p2;
EcsPool<Component374> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component436>().Inc<Component150>().End();
   _p1 = _world.GetPool<Component436>();
   _p2 = _world.GetPool<Component150>();
   _pl0 = _world.GetPool<Component374>();
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
