using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System140 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component230> _p1;
EcsPool<Component16> _p2;
EcsPool<Component259> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component230>().Inc<Component16>().Inc<Component259>().End();
   _p1 = _world.GetPool<Component230>();
   _p2 = _world.GetPool<Component16>();
   _p3 = _world.GetPool<Component259>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
