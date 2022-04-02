using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System152 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component167> _p1;
EcsPool<Component114> _p2;
EcsPool<Component329> _p3;
EcsPool<Component316> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component167>().Inc<Component114>().Inc<Component329>().Inc<Component316>().End();
   _p1 = _world.GetPool<Component167>();
   _p2 = _world.GetPool<Component114>();
   _p3 = _world.GetPool<Component329>();
   _p4 = _world.GetPool<Component316>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
